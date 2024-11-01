using System;

class Circle : Shape {

    private int _side;

    public Circle(int side) : base()
    {
        _side = side;
    } 

    public override void GetArea(){

        return _side * 2;
    }
}