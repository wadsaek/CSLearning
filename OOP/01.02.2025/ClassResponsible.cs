namespace _01._02._2025 {
    internal class ClassResponsible : RegularWorker {
        public override int Pay() {
            return base.Pay() + 1200 + fclass.GetLength();
        }
        FClass fclass;
        Car car;
    }
}
