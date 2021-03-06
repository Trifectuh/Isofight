﻿using UnityEngine;
using System.Collections;

public class HitboxManager : MonoBehaviour
{
    string player;
    bool hitboxActive;

	void Start()
    {
        player = this.name;
        hitboxActive = false;
	}

    void OnTriggerStay(Collider col)
	{
        if (hitboxActive == true)
        {
            hitboxActive = false;
            Debug.Log(col.gameObject.name + " hit !");
            col.gameObject.transform.parent.BroadcastMessage("TakeDamage", 10);
            col.gameObject.transform.parent.BroadcastMessage("AddSuperPoints", 1);
            GetComponentInParent<SuperCounter>().AddSuperPoints(2);
        }
	}

    public void ActivateHitbox()
    {
        hitboxActive = true;
    }

    public void DeactivateHitbox()
    {
        hitboxActive = false;
    }
}