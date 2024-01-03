using System;
using System.Runtime.InteropServices.Marshalling;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("\nStudent\t\tExam Score\tOverall Grade\t\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    int sumAssignmentScore = 0;
    int extraAssignment = 0;
    int gradedAssignments = 0;
    int examScore = 0;
    int extraScore = 0;
    decimal currentStudentGrade = 0.00m;
    decimal extraCreditScore = 0.00m;
    decimal examScoreProm = 0.00m;
    decimal extraCreditPoints =0.00m;
 

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
        {
            //Exam Score
            sumAssignmentScore += score;
            examScore = sumAssignmentScore;
        }
        else
        {
        //Extra Credit
            extraAssignment += 1;
            extraScore += score;
            sumAssignmentScore += score / 10;
            
        }
    }
    // exam score.
    examScoreProm = (decimal)examScore / examAssignments;
    //extra credit score.
    extraCreditScore = (decimal)extraScore / extraAssignment;
    //Overall Grade
    currentStudentGrade = (decimal)sumAssignmentScore / examAssignments;
    // extraCreditsPoints: examScores - overallGrades
    extraCreditPoints =  currentStudentGrade - examScoreProm;
    
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}\t\t{examScoreProm}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t\t{extraCreditScore} ({extraCreditPoints} pts)");

}
Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();




