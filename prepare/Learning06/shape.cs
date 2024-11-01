using System;

public abstract class Shape{

    private string _Color;


    public string _color {

        get { return _color; }
        set { _color = value; }
    }

    public virtual void GetArea(int area){

        return area;

    } 

}