using UnityEngine;

//腳本化物件儲存資料在專案裡面
[CreateAssetMenu(fileName = "英雄檔案", menuName = "LoL/英雄檔案")]
public class HeroData : ScriptableObject
{
    [Header("生命"),Range(0f, 1000f)]
    public float hp;
    [Header("魔力"), Range(0f, 1000f)]
    public float mp;
    [Header("移動速度"), Range(0f, 100f)]
    public float moveSpd;
    [Header("物理攻擊"), Range(0f, 100f)]
    public float phyAtk;
    [Header("魔法攻擊"), Range(0f, 100f)]
    public float magAtk;
    [Header("攻擊冷卻"), Range(0f, 5f)]
    public float normalAtkCD;
    [Header("物理防禦"), Range(0f, 100f)]
    public float phyDef;
    [Header("魔法防禦"), Range(0f, 100f)]
    public float magDef;
    [Header("技能組")]
    public Skill[] skills;
}

[System.Serializable]
public class Skill
{
    [Header("技能傷害"), Range(0f, 500f)]
    public float damage;
    [Header("技能消耗"), Range(0f, 500f)]
    public float cost;
    [Header("技能冷卻"), Range(0f, 200f)]
    public float cd;
    [Header("技能圖片")]
    public Sprite image;
}
