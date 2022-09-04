﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser2
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(pattern, className);
            try
            {
                if (result.Success)
                {
                    try
                    {

                        {
                            Assembly assembly = Assembly.GetExecutingAssembly();
                            Type moodAnalysetype = assembly.GetType(className);
                            return Activator.CreateInstance(moodAnalysetype);
                        }
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Your Input is not Valid");
                        throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
                    }
                }
                else
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor not Found");
                }
            }
            catch (MoodAnalyserCustomException e)
            {
                return e.Message;
            }
        }

    }
}
