namespace _01._02._2025 {
    internal class CoahAdamWorker : Worker {
        public CoahAdamWorker(string name, int id, DateOnly birthDate, DateOnly startOfWork) : base(name, id, birthDate, startOfWork) { }
        public CoahAdamWorker(string name, int id) : base(name, id) { }
        public override int Pay() {
            return GetWorkHours() * 19;
        }
    }
}
