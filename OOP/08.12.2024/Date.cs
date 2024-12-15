using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _08._12._2024 {
    public class Date {
        uint years;
        byte months;
        byte days;
        public Date(uint years, byte months, byte days) {
            SetDays(days);
            SetMonths(months);
            SetYears(years);            
        }
        public Date(Date date) {
            days = date.days;
            months = date.months;
            years = date.years;
        }

        public void SetYears(uint year) {
            years = year;
        }
        public void SetMonths(byte months) {
            if (months <= 12) this.months = months;
        }
        public void SetDays(byte days) {
            if (days <= 31) this.days = days;
        }

        public byte GetDays() {
            return days;
        }
        public byte GetMonths() {
            return months;
        }
        public uint GetYears() {
            return years;
        }

        public override string ToString() {
            return $"{GetDays()}.{GetMonths()}.{GetYears()}";
        }
    }
}
