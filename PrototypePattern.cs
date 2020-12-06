using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player
{
    private string lv; //Level
    private string exp; //Kinh nghiem
    private string hp; // Mau
    private string mp; // Mana
    private string others;

    public Player(string lv, string exp, string hp, string mp, string other = "")
    {
        this.lv = lv;
        this.exp = exp;
        this.hp = hp;
        this.mp = mp;
        this.others = other;
    }
    public Player clone()
    {
        try
        {
            return this.MemberwiseClone() as Player;
        }
        catch (System.Exception)
        {
            Debug.Log("Error");
        }
        return null;
    }
    public string getText()
    {
        return "Player [Lv=" + lv + ", Exp=" + exp + ", Hp=" + hp + ", Mp=" + mp
                + ", others=" + others + "]";
    }

    public void setOthers(string others)
    {
        this.others = others;
    }
}

public class PrototypePattern : MonoBehaviour
{
    public Text txtLabel;
    private void Start()
    {
        Player PlayerDefault = new Player("1", "0", "100", "100");
        Player PlayerClone = PlayerDefault.clone();
        PlayerClone.setOthers("Skill 1, Skill 2, Skill 3");
        txtLabel.text += PlayerDefault.getText() + "\n";
        txtLabel.text += PlayerClone.getText() + "\n";
    }
}
