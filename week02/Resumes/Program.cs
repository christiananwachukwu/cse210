using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume("Christiana Nwachukwu");
        
        Job job1 = new Job();
        job1._jobTitle = "Health Education Teacher";
        job1._company = "F.C.G.C.S.School";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "BYU Idaho";
        job2._startYear = 2024;
        job2._endYear = 2026;

    
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}