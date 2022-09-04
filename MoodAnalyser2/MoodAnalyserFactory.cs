using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser2
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string className)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type moodAnalysetype = assembly.GetType(className);
            return Activator.CreateInstance(moodAnalysetype);
        }
    }
}
