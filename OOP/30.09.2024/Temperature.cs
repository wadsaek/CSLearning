namespace _30._09_2024.Classes;

class Temperature{
    double _kelvin;
    public Temperature SetKelvin(double kelvin){
        if(kelvin > 0) this._kelvin = kelvin;
        return this;
    }
    public Temperature SetCelsius(double celsius){
        double kelvin = celsius + 273.4;
        return SetKelvin(kelvin);
    }
    public Temperature SetFahrenheit(double farrenheit){
        double celsius = 5*(farrenheit-32)/9;
        return SetCelsius(celsius);
    }

    public double GetKelvin(){
        return _kelvin;
    }
    public double GetCelsius(){
        return _kelvin - 273.4;
    }
    public double GetFahrenheit(){
        return GetCelsius()*9/5 +32;
    }
}
