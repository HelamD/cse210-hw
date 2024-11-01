using System;

class Square : Shape
{
    private int _side;
    
    public Square(int side) : base()
    {
        _side = side;
    } 

    public override void GetArea(){

        return _side * 2;
    }

}