namespace _30._09_2024.Classes;

class Clock {
    ulong seconds;
    
    public Clock(byte seconds, byte minutes, byte hours){
        if(minutes < 60){
            this.seconds += (ulong)minutes * 60;
        }
        if(seconds < 60){
            this.seconds += (ulong)seconds;
        }
    }

    public Clock(){}

    public void AddHours(byte hours){
        if(hours < 24){
            this.seconds += (ulong)hours * 60 * 60;
        }
    }
    public void AddMinutes(byte minutes){
        if(minutes < 24){
            this.seconds += (ulong)minutes * 60;
        }
    }
    public void AddSecond(byte seconds){
        if(seconds < 24){
            this.seconds += (ulong)seconds;
        }
    }
    
    public byte GetHours(bool _24Hour) {
        return ((byte)(seconds / 60 / 60 %24 - (ulong)(_24Hour ? 0 : 12)));
    }
    public byte GetMinutes() {
        return ((byte)(seconds / 60 % 60 ));
    }
    public byte GetSeconds() {
        return ((byte)(seconds%60));
    }
}
