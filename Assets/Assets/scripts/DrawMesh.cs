using UnityEngine;
using UnityEngine.UI;

public class DrawMesh : MonoBehaviour
{
    public RawImage rawImage; // Ссылка на RawImage
    private Texture2D texture; // Текстура для рисования

    private bool DrawOrErase;

    void Start()
    {
        // Создаем текстуру и очищаем её
        texture = new Texture2D(300, 400); 
        ClearTexture();
        rawImage.texture = texture; // Назначаем текстуру Raw Image
    }

    private Vector2 lastMousePosition;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            DrawOrErase = true;
        }
        else if (Input.GetMouseButton(1))
        {
            DrawOrErase = false;
        }

        if (Input.GetMouseButton(0) || Input.GetMouseButton(1)) 
        {
            Vector2 currentMousePosition = Input.mousePosition;
            
            // Проверяем, если это первое движение мыши
            if (lastMousePosition == Vector2.zero)
            {
                lastMousePosition = currentMousePosition; // Сохраняем начальную позицию
            }

            // Рисуем линию от последней позиции до текущей
            DrawLine(lastMousePosition, currentMousePosition);

            // Обновляем последнюю позицию
            lastMousePosition = currentMousePosition;
        }
        else
        {
            // Сбрасываем последнюю позицию, когда кнопка не нажата
            lastMousePosition = Vector2.zero;
        }
    }

    private void DrawLine(Vector2 start, Vector2 end, int brushSize = 1)
    {
        if (DrawOrErase == true)
        {
            brushSize = 1;
        }
        else if (DrawOrErase == false)
        {
            brushSize = 30;
        }
        // Преобразуем координаты в текстурные
        Vector2 startTex = new Vector2((start.x / rawImage.rectTransform.rect.width) * texture.width,
                                        (start.y / rawImage.rectTransform.rect.height) * texture.height);
        Vector2 endTex = new Vector2((end.x / rawImage.rectTransform.rect.width) * texture.width,
                                    (end.y / rawImage.rectTransform.rect.height) * texture.height);



        // Рисуем линию между двумя точками
        DrawBetweenPoints((int)startTex.x, (int)startTex.y, (int)endTex.x, (int)endTex.y, brushSize);
    }

    private void DrawBetweenPoints(int x0, int y0, int x1, int y1, int brushSize)
    {
        int dx = Mathf.Abs(x1 - x0);
        int dy = Mathf.Abs(y1 - y0);
        int sx = x0 < x1 ? 1 : -1;
        int sy = y0 < y1 ? 1 : -1;
        int err = dx - dy;

        while (true)
        {
            // Рисуем круг вокруг текущей точки
            for (int i = -brushSize; i <= brushSize; i++)
            {
                for (int j = -brushSize; j <= brushSize; j++)
                {
                    if (i * i + j * j <= brushSize * brushSize)
                    {
                        if (x0 + i >= 0 && x0 + i < texture.width && y0 + j >= 0 && y0 + j < texture.height)
                        {
                            if (DrawOrErase == true)
                            {
                                texture.SetPixel(x0 + i, y0 + j, Color.black);
                            }
                            else if (DrawOrErase == false)
                            {
                                texture.SetPixel(x0 + i, y0 + j, Color.white);
                            }
                        }
                    }
                }
            }

            // Если достигли конца линии, выходим из цикла
            if (x0 == x1 && y0 == y1) break;

            int err2 = err * 2;
            if (err2 > -dy)
            {
                err -= dy;
                x0 += sx;
            }
            if (err2 < dx)
            {
                err += dx;
                y0 += sy;
            }
        }

        texture.Apply(); // Применяем изменения к текстуре
    }


    private void ClearTexture()
    {
        Color[] pixels = new Color[texture.width * texture.height];
        for (int i = 0; i < pixels.Length; i++)
        {
            pixels[i] = Color.white; 
        }
        texture.SetPixels(pixels);
        texture.Apply(); // Применяем изменения к текстуре
    }
}