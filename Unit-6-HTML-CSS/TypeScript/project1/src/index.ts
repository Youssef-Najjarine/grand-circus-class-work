// typescript file goes here
console.log("Welcome to my first TypeScript program")

interface Student {
    studentName: string;
    className: string;
    startDate: number;
}

class Roster {
    studentList: Student[];
    constructor() {
        this.studentList = [];
    }
    addStudent(newStudent: Student): void {
        this.studentList.push(newStudent);
    }

    getAllStudents(): Student[] {
        return this.studentList;
    }
}

let classRoster: Roster = new Roster();

classRoster.addStudent({studentName: "Youssef", className: "Angular", startDate: 20250623});
classRoster.addStudent({studentName: "Zach", className: "English", startDate: 20250623});
classRoster.addStudent({studentName: "Frank", className: "Math", startDate: 20250623});

classRoster.getAllStudents().forEach(aStudent => {
    console.log(aStudent);
});