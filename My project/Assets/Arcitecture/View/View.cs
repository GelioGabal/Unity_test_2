using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class View : MonoBehaviour
{
    public abstract void disc(bool disc);
    public abstract void setLogo(string logoTest);
    public abstract void setDiscr(string descript);
    public abstract void setObj(List<Objects> objected);



}
