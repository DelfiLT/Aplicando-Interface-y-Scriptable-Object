using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, Ipresentation
{
    [SerializeField] private ScriptableEnemy enemyData;
    public string enemyName;
    public int hp;
    public string greatings;

    void Start()
    {
        enemyName = enemyData.Name;
        hp = enemyData.HP;
        greatings = enemyData.Greatings;
    }
 
    public void Action() 
    {
        enemyData.PrintData();
    }

}
