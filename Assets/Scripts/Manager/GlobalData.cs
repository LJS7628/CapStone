using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;


public class GlobalData
{
    public static int[] index = new int[3];
    public static int choice=0;
    public static int selected=0;

    public static int[] PlayerHP= new int[6];
    public static int PlayerAttack = 5;
    public static int[] PlayerDefence = new int[6];

    public static int MonsterHP = 40;
    public static int MonsterAttack = 5;
    public static int MonsterDefence = 8;
    public static int MonsterState = -1;
    public static int M_Dead = 0;

    public static int isPressed = 0;
    public static int isDead = 0;
    public static int isHurt = 0;
}
