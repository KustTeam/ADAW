using UnityEngine;

public class Take : MonoBehaviour
{
    public float teleportOffset = 0.5f; // Смещение при телепортации
    private GameObject currentItem; // Текущий предмет в инвентаре
    public float distanceFromTable = 0.5f; // Смещение от стола вперед
    public LayerMask tableLayer; // Слой стола
    public LayerMask PawykLayer;
    public static string eatAtHand = null;
    public float teleportDistance = 7.2f; // Максимальная дистанция для телепортации

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && currentItem == null) // Подбор предмета
        {
            TryPickUpItem();
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1) && currentItem != null) // Телепортация предмета
        {
            TryTeleportItem();
        }
    }

    private void TryPickUpItem()
    {
        // Проверяем, есть ли предмет рядом
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 5f); // Радиус подбора
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("фруктовый салат") || hitCollider.CompareTag("пюре") || hitCollider.CompareTag("просто ягоды") || hitCollider.CompareTag("недоеденные овощи") || hitCollider.CompareTag("макароны") || hitCollider.CompareTag("каша") || hitCollider.CompareTag("жаренная картошка") || hitCollider.CompareTag("дешёвый салат") || hitCollider.CompareTag("брокколи с брокколи") || hitCollider.CompareTag("борщ без мяса")) // Предмет должен иметь тег "Item"
            {
                currentItem = hitCollider.gameObject; // Сохраняем текущий предмет
                hitCollider.gameObject.SetActive(false); // Скрываем предмет после подбора
                eatAtHand = currentItem.name;
                return;
            }
        }
    }

    private void TryTeleportItem()
    {
        if (currentItem != null && IsLookingAtTable())
        {
            // Находим позицию стола для телепортации
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, teleportDistance, tableLayer))
            {
                Vector3 teleportPosition = hit.point + Vector3.up * teleportOffset + hit.normal * distanceFromTable; // Смещение вверх и вперед
                currentItem.transform.position = teleportPosition; // Телепортируем предмет
                currentItem.SetActive(true); // Показываем предмет
                eatAtHand = null;
                currentItem = null; // Сбрасываем текущий предмет
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, teleportDistance, PawykLayer))
            {
                Destroy(currentItem);
                eatAtHand = null;
                currentItem = null; // Сбрасываем текущий предмет
            }
        }
    }

    private bool IsLookingAtTable()
    {
        // Проверяем, смотрит ли игрок на стол
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, teleportDistance, tableLayer)) // Проверяем вперёд на наличие стола
        {
            return true;
        }
        if (Physics.Raycast(transform.position, transform.forward, out hit, teleportDistance, PawykLayer))
        {
            return true;
        }
        return false;
    }
}
