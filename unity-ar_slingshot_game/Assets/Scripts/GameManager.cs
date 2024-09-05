using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.ARFoundation;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public GameObject targetPrefab;
    public PlaneSelectionManager planeSelectionManager;
    private ARPlane selectedPlane;
    public int numOfTargets = 5;

    public void StartGame()
    {
        // get the selected plane from the plane selection manager
        selectedPlane = planeSelectionManager.selectedPlaneGetter();
        
        if (!selectedPlane)
        {
            Debug.Log("No selected plane");
        }
        else
        {
            // hide selected plane
            selectedPlane.GameObject().SetActive(false);
            // instantiate targets = num
            for (int i = 0; i < numOfTargets; i++)
            {
                TargetRandomizer();
            }
        }
    }
    public void TargetRandomizer()
    {
            Vector2 planeSize = selectedPlane.size;
                    // Calculate local positions within the plane bounds
            float localX = Random.Range(-planeSize.x / 2, planeSize.x / 2);
            float localZ = Random.Range(-planeSize.y / 2, planeSize.y / 2);
            Vector3 localPosition = new Vector3(localX, 0.1f, localZ); // Adding a slight Y offset to ensure visibility
            Vector3 worldPosition = selectedPlane.transform.TransformPoint(localPosition);

            // Instantiate the target at the calculated world space position
            Instantiate(targetPrefab, worldPosition, Quaternion.identity);
    }
}

