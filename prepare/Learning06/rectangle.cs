using System;

class Rectangle : Shape {

    private int _side;

    public Rectangle(int side) : base()
    {
        _side = side;
    } 

    public override void GetArea(){

        return _side * 2;
    }

}