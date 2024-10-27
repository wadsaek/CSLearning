namespace _30._09_2024.Classes;

class Bucket{   
    double maximum;
    double value;
    string? name;

    public Bucket(double maximum, double value, string name)
    {
        this.maximum = maximum>0 ? maximum : 0;
        this.value = 0<=value && value<=this.maximum ? value : 0;
        this.name = name.Length >0 ? name : null;
    }

    public double GetMaximum(){
       return maximum;
    }

   public void SetMaximum(double newMax){
       if(newMax > 0 && newMax >= value){
           maximum = newMax;
       }
    }

   public double GetValue(){
       return value;
   }
   public void SetValue(double newValue){
       if (newValue>=0 && newValue <= maximum){
           value = newValue;
       }
   }

   public string? GetName(){
       return name;
   }
   public void SetName(string newName){
       if(newName.Length>0){
           name = newName;
       }
   }

   public double Empty(){
       double returned = value;
       value = 0;
       return value;
   }

   public bool IsEmpty() => value == 0;

   public bool Fill(double valueToAdd){
       if (valueToAdd>=0 && valueToAdd + value <= maximum){
           value+=valueToAdd;
           return true;
       }
       return false;
   }

   public bool PoorInto(Bucket other){
       bool success = other.Fill(this.value);
       if(success){
           this.value = 0;
       }
       return success;
   }
}


