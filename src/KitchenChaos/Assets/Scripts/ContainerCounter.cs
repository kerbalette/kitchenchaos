using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter {

    public event EventHandler OnPlayerGrabbedObject;
    
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    
    public override void Interact(Player player) {
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);
        kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);
        kitchenObjectTransform.localPosition = Vector3.zero;
        
        OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
    }
    
}