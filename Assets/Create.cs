using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject spherePrefab; // Префаб шара
    public Vector3 moveDirection = Vector3.forward; // Направление движения
    public float moveSpeed = 5f; // Скорость движения

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Получаем точку клика в мире
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 spawnPosition = hit.point;
                GameObject sphere = Instantiate(spherePrefab, spawnPosition, Quaternion.identity);
                // Добавляем компонент движения
                SphereMover mover = sphere.AddComponent<SphereMover>();
                mover.direction = moveDirection.normalized;
                mover.speed = moveSpeed;

                // Удаляем шар через 3 секунды
                Destroy(sphere, 3f);
            }
        }
    }
}