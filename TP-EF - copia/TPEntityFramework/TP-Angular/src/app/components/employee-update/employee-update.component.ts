import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {Router} from '@angular/router';

import { Employees } from 'src/app/models/employee';
import { EmployeeService } from '../../service/employee.service'

@Component({
  selector: 'employeeUpdate',
  templateUrl: './employee-update.component.html',
  styleUrls: ['./employee-update.component.scss'],
  providers: [{ provide: Window, useValue: window }
]
})
export class EmployeeUpdateComponent implements OnInit {

  employeesForm: FormGroup;
  
  @Input()
  idEmployee: number;

  

  constructor(
    private readonly fb: FormBuilder,
    private _employeesService : EmployeeService,
    private router : Router
    ) { }

  

  ngOnInit(): void {
    this.employeesForm = this.fb.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required]
    })
  }

  onSubmit(): void {
    console.log(this.employeesForm.value);
  }

  update(){
    var id = 0;
    var name = this.employeesForm.get('firstName').value;
    var lastName =  this.employeesForm.get('lastName').value;
    var employee = new Employees(id, name, lastName);
    this._employeesService.updateEmployee(this.idEmployee, employee).subscribe(
      response => {
        this.reloadCurrentPage();
      },
      error => {
        this.router.navigate(['error']);
      }
    );
    this.reloadCurrentPage();
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
