using UnityEngine;

public class RotateAroundPlayer : MonoBehaviour
{
    public float rotationSpeed = 50f; // Скорость вращения

    private Transform playerTransform;

    void Update()
    {
        // Найти объект с тегом "Player"
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        
        if (player != null)
        {
            playerTransform = player.transform;

                // Вычисляем направление к игроку
                Vector3 direction = (playerTransform.position - transform.position).normalized;

                // Вычисляем угол поворота
                Quaternion lookRotation = Quaternion.LookRotation(direction);

                // Поворачиваем объект к игроку с заданной скоростью
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);
        }
    }
}