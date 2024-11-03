using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class View : MonoBehaviour
{
    public abstract void ColObg(List<Objects> objs);
    public abstract void logoText(string logoText);
    public abstract void descriptionText(string descriptionText);
    public abstract void priseText(string priseText);
    public abstract void discontText(string discontText);


}
