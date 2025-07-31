using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle : MonoBehaviour
{
    public float speed = 5f; // Скорость движения

    private CharacterController controller;
    private Vector3 velocity;
    private Transform tran;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        tran = GetComponent<Transform>();
        povorot.z_camera = tran.rotation.z;
        
    }

    void Update()
    {

        // Получаем ввод от пользователя
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");


        // Создаем вектор движения
        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        // Двигаем персонажа
        controller.Move(move * speed * Time.deltaTime);
    }
}