namespace _02._02._2025;

class Program {
    static void Main(string[] args) {
        Resident[] a = [
                new Breathe("a"),
                new Breathe("a"),
                new Resident(),
                new Breathe("h"),
                new Breathe("h"),
                new Breathe("n")
        ];
        foreach (string str in MostUsedHospital(a))
            Console.WriteLine(str);
    }

    static string[] MostUsedHospital(Resident[] arr) {
        return arr
            .Select(b => b as Breathe)
            .Where(b => b is not null)
            .Select(b => b!.Hospital)
            .GroupBy(h => h, (key, group) => new HospWithCount(key, group.Count()))
            .Aggregate(new { value = 0, arr = new List<HospWithCount>() }, (acc, cur) => {
                if (cur.Count == acc.value) { acc.arr.Add(cur); return acc;}
                if (acc.value < cur.Count) return new { value = cur.Count, arr = new List<HospWithCount> { cur } };
                return acc;
            })
            .arr.Select(h => h.Key)
            .ToArray();
    }
    record HospWithCount(string Key, int Count) { }

}
