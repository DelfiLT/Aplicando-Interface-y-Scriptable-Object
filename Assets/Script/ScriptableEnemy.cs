using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EnemyScriptable", menuName = "EnemyMenu")]
public class ScriptableEnemy : ScriptableObject
{
    [SerializeField]private string enemyName;
    [SerializeField]private int hp;
    [SerializeField]private string greatings;

    public string Name { get { return enemyName; } }
    public int HP { get { return hp; } }
    public string Greatings { get {  return greatings; } }

    public void PrintData() 
    {
        Debug.Log(enemyName);
        Debug.Log(hp);
        Debug.Log(greatings);
    }
}
