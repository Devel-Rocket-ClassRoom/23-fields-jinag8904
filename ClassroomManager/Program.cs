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