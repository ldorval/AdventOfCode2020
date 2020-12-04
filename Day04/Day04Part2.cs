using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Day04
{
    public class Day04Part2
    {
        private static readonly IList<string> RequiredFields = new List<string>{"byr","iyr","eyr","hgt","hcl","ecl","pid"};
        private static readonly IList<string> EyeColorPossibleValues = new List<string>{"amb", "blu", "brn", "gry", "grn", "hzl", "oth"};
        
        public static int Solve(string passportsInput)
        {
            var passports = passportsInput.Split(Environment.NewLine + Environment.NewLine);
            return passports.Count(IsValid);
        }

        private static bool IsValid(string passport)
        {
            var fields = passport.Split(Environment.NewLine).SelectMany(x => x.Split(" ")).ToList();
            
            if (MissingRequiredFields(fields))
                return false;
            
            var isValid = ValidateYear(GetField("byr", fields), 1920, 2002) &&
                   ValidateYear(GetField("iyr", fields), 2010, 2020) &&
                   ValidateYear(GetField("eyr", fields), 2020, 2030) &&
                   ValidateHeight(GetField("hgt", fields)) &&
                   ValidateHairColor(GetField("hcl", fields)) &&
                   ValidateEyeColor(GetField("ecl", fields)) &&
                   ValidatePassportId(GetField("pid", fields));

            return isValid;
        }

        private static bool MissingRequiredFields(IList<string> fields)
        {
            return RequiredFields.Any(requiredField => !fields.Any(x => x.Contains(requiredField)));
        }

        private static bool ValidateYear(string yearValue, int min, int max)
        {
            if (yearValue == null)
                return false;

            var year = Convert.ToInt32(yearValue);
            return year >= min && year <= max;
        }

        private static bool ValidateHeight(string heightValue)
        {
            var unit = heightValue.Substring(heightValue.Length - 2, 2);
            var value = Convert.ToInt32(heightValue.Replace("cm", "").Replace("in", ""));

            return unit switch
            {
                "cm" => value >= 150 && value <= 193,
                "in" => value >= 59 && value <= 76,
                _ => false
            };
        }

        private static bool ValidateHairColor(string hairColorValue)
        {
            return new Regex("^#([a-fA-F0-9]{6})$").IsMatch(hairColorValue);
        }

        private static bool ValidateEyeColor(string eyeColorValue)
        {
            return EyeColorPossibleValues.Any(x => x == eyeColorValue);
        }

        private static bool ValidatePassportId(string passportIdValue)
        {
            if (passportIdValue.Length != 9)
                return false;
            
            return long.TryParse(passportIdValue, out _);
        }

        private static string GetField(string fieldTag, IEnumerable<string> fields)
        {
            var field = fields.First(x => x.Contains(fieldTag));
            return field.Split(":")[1];
        }
    }
}

