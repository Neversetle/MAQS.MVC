$(document).ready(function () {
    $('#tblCorp').DataTable(
        {
            ajax: {
                url: "Home/GetEmployeeList",
                type: "POST",
            },
            processing: true,
            serverSide: true,
            filter: true,
            columns: [
                { data: "employeeId", name: "EmployeeId" },
                { data: "employeeFirstName", name: "EmployeeFirstName" },
                { data: "employeeLastName", name: "EmployeeLastName" },
                { data: "salary", name: "Salary" },
                { data: "designation", name: "Designation" },
            ]
        }
    );
});