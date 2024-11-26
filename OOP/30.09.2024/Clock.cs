namespace _30._09_2024.Classes;

class Clock {
    ulong seconds;
    
    public Clock(byte seconds, byte minutes, byte hours){
        AddHours(hours);
        AddMinutes(minutes);
        AddSeconds(seconds);
    }

    public Clock(){}

    public void AddHours(byte hours){
        if(hours < 24){
            this.seconds += (ulong)hours * 60 * 60;
        }
    }
    public void AddMinutes(byte minutes){
        if(minutes < 60){
            this.seconds += (ulong)minutes * 60;
        }
    }
    public void AddSeconds(byte seconds){
        if(seconds < 60){
            this.seconds += (ulong)seconds;
        }
    }
    
    public byte GetHours24() {
        return ((byte)(seconds / 60 / 60 %24));
    }
    public byte GetHours12(){
        return (byte)(GetHours24()%12);
    }
    public byte GetMinutes() {
        return ((byte)(seconds / 60 % 60 ));
    }
    public byte GetSeconds() {
        return ((byte)(seconds%60));
    }
}
