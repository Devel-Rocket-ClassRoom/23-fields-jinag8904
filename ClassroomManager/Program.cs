using System;

ClassroomManager class1 = new ClassroomManager("1");
ClassroomManager class2 = new ClassroomManager("2");

class1.AddStudent("홍길동");
class1.AddStudent("김철수");
class1.AddStudent("이영희");

class2.AddStudent("박민수");
class2.AddStudent("정수진");

class1.ShowStudents();
Console.WriteLine();
class2.ShowStudents();
Console.WriteLine();

ClassroomManager.ShowTotalClassRooms();

class ClassroomManager
{
    const int maxStudent = 5;
    readonly string className;
    private string[] students = new string[maxStudent];
    private int currentStudentTotal = 0;
    private static int classRoomCount = 0;

    public ClassroomManager(string className)
    {
        this.className = className;
        classRoomCount++;
    }

    public void AddStudent(string name)
    {
        if(currentStudentTotal < maxStudent)
        {
            students[currentStudentTotal++] = name;
        }
        else
        {
            Console.WriteLine("반의 정원이 차 있습니다.");
        }
    }

    public void ShowStudents()
    {
        Console.WriteLine($"=== {className}반 학생 목록 ({currentStudentTotal}/{maxStudent}) ===");

        for (int i = 0; i < currentStudentTotal; i++) {
            Console.WriteLine($"{i+1}. {students[i]}");
        } 
    }

    static public void ShowTotalClassRooms()
    {
        Console.WriteLine($"전체 교실 수: {classRoomCount}");
    }
}