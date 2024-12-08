using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _08._12._2024 {
    public class Date {
        uint _days;
        public Date(uint year, byte month, byte day) {
            _days += year * 365;
            if(month <= 12) _days += (uint)(month * 31);
            if (day <= 31) _days += day;
        }
        public Date(Date date) {
            _days = date._days;
        }

        public void AddSubtractMonths(sbyte month) {
            if (month <= 12 && month >= -12 && month * -31 < _days) _days = (uint)((int)_days +(month * 31));
        }
        public void AddSubtractYears(int years) {
            if (years * -365 < _days) _days = (uint)((int)_days + (years * 365));
        }
        public void AddSubtractDays(sbyte days) {
            if (days <= 12 && days >= -12 && -days < _days) _days = (uint)((int)_days + days);
        }
        public byte GetDays() {
            return (byte)(_days % 31);
        }
        public byte GetMonths() {
            return (byte)((_days / 31) %12);
        }
        public byte GetYears() {
            return (byte)(_days / 365);
        }

        public override string ToString() {
            return $"{GetDays()}.{GetMonths()}.{GetYears()}";
        }
    }
}
