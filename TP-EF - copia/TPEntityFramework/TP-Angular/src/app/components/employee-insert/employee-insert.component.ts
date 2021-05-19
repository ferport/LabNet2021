import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {Router} from '@angular/router';

import { Employees } from 'src/app/models/employee';
import { EmployeeService } from '../../service/employee.service'

@Component({
  selector: 'employeeInsert',
  templateUrl: './employee-insert.component.html',
  styleUrls: ['./employee-insert.component.scss'],
  providers: [EmployeeService]
})
export class EmployeeInsertComponent implements OnInit {

  employeesForm: FormGroup;

  constructor(
    private readonly fb: FormBuilder,
    private _employeesService : EmployeeService,
    private router:Router,
    ) { }

  ngOnInit(): void {
    this.employeesForm = this.fb.group({
      firstName: ['', ],
      lastName: ['', Validators.required]
    })
  }

  onSubmit(): void {
    console.log(this.employeesForm.value);
  }

  save(){
    var id = 0;
    var name = this.employeesForm.get('firstName').value;
    var lastName =  this.employeesForm.get('lastName').value;
    var employee = new Employees(id, name, lastName);
    this._employeesService.addEmployee(employee).subscribe(
      response => {
        this.reloadCurrentPage();
      },
      error => {
        this.router.navigate(['error']);
      }
    );
    
  }

 reloadCurrentPage() {
  window.location.reload();
 }

  get firstName() {
  return this.employeesForm.get('firstName');
  }
  get lastName() {
  return this.employeesForm.get('lastName');
  }

}
