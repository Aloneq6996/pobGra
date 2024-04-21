using System;
using TMPro;
using UnityEngine;
public class TurretPlacer : MonoBehaviour
{
    public GameObject turretPrefab;
    public moneys moneys;
    private GameObject _turret;
    private GameObject parent;
    private void Start()
    {
        // moneys.money = GameObject.Find("bank").GetComponent<moneys>().money;
        parent = GameObject.Find("Turrets");
    }
    private bool CanPlaceturret(int price)
    {

        if (moneys.money >= price)
        {
            Destroy(gameObject);
            moneys.moneyDecrease(price);
            return true;
        }
        return false;
    }

    private void OnMouseUp()
    {

        if (CanPlaceturret(100))
        {
            _turret = (GameObject)
                Instantiate(turretPrefab, transform.position, Quaternion.identity);
            _turret.transform.SetParent(parent.transform);
        }
    }

}