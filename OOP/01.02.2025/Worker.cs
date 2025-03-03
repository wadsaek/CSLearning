namespace _01._02._2025;

public abstract class Worker {
    string name;
    int id;
    int workHours;
    DateOnly birthDate;
    DateOnly startOfWork;

    public Worker(string name, int id, DateOnly birthDate, DateOnly startOfWork) {
        this.name = name;
        this.id = id;
        this.birthDate = birthDate;
        this.startOfWork = startOfWork;
    }

    public Worker(string name, int id) {
        this.name = name;
        this.id = id;
        birthDate = new DateOnly(1970, 1, 1);
        startOfWork = new DateOnly(2024, 9, 8);
    }
    public abstract int Pay();
    
    public int GetWorkHours(){
        return workHours;
    }
}
