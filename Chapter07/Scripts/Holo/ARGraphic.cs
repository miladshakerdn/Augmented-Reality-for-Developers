﻿using UnityEngine;

public class ARGraphic : InstructionElement {
    private GameObject currentGraphic;

    protected override void InstructionUpdate(InstructionStep step) {
        Debug.Log("ARGraphic:" + step.ARPrefabName);

        // clear current graphic
        if (currentGraphic != null) {
            Destroy(currentGraphic);
            currentGraphic = null;
        }

        // load step's graphic
        if (!string.IsNullOrEmpty(step.ARPrefabName)) {
            Object data = Resources.Load(step.ARPrefabName, typeof(GameObject));
            currentGraphic = Instantiate(data, transform ) as GameObject;
        }
    }
}
