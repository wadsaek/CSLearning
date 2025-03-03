namespace _01._02._2025 {
    internal class RegularWorker : Worker {
        public RegularWorker(string name, int id, DateOnly birthDate, DateOnly startOfWork) : base(name, id, birthDate, startOfWork) { }
        public RegularWorker(string name, int id): base(name, id) {}
        public override int Pay(){
            return GetWorkHours() * 22 + 330;
        }
    }
}
