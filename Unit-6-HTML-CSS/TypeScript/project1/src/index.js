// typescript file goes here
console.log("Welcome to my first TypeScript program");
var Roster = /** @class */ (function () {
    function Roster() {
        this.studentList = [];
    }
    Roster.prototype.addStudent = function (newStudent) {
        this.studentList.push(newStudent);
    };
    Roster.prototype.getAllStudents = function () {
        return this.studentList;
    };
    return Roster;
}());
var classRoster = new Roster();
classRoster.addStudent({ studentName: "Youssef", className: "Angular", startDate: 20250623 });
classRoster.addStudent({ studentName: "Zach", className: "English", startDate: 20250623 });
classRoster.addStudent({ studentName: "Frank", className: "Math", startDate: 20250623 });
classRoster.getAllStudents().forEach(function (aStudent) {
    console.log(aStudent);
});
