namespace _30._09_2024.Classes;

class Box{
    uint length, width, height;

    public Box(uint length, uint width, uint height)
    {
        SetLength(length);
        SetWidth(width);
        SetHeight(height);
    }

    uint GetLength(){
        return length;
    }
    uint GetWidth(){
        return width;
    }
    uint GetHeight(){
        return height;
    }

    public void SetLength(uint value){
        if(ValidValue(value)) length = value; 
    }
    public void SetWidth(uint value){
        if(ValidValue(value)) width = value; 
    }
    public void SetHeight(uint value){
        if(ValidValue(value)) height = value; 
    }
    private bool ValidValue(uint value){
        return value<=200 && value != 0;
    }

    public uint Volume(){
        return length * width * height;
    }

    public uint FrontFaceArea(){
        return width * height;
    }

    public uint SideFaceArea(){
        return length * height;
    }

    public uint TopFaceArea(){
        return length * width;
    }
}
