import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';

import { Employees } from '../../models/employee';
import { EmployeeService } from '../../service/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.scss'],
  providers: [EmployeeService]
})
export class EmployeeListComponent implements OnInit {
  idEmployee : number;
  public employees : Employees[];
  public employee : Employees;
  id : number;
  showInsert = 1;
  showUpdate = 1;

  constructor(
    private router:Router,
    private _employeesService : EmployeeService
    
    ) {}
  ngOnInit() {
    this.getEmployess();
  }

  getEmployess(){
    this._employeesService.getEmployees().subscribe(
      response =>{
        if(response){
          this.employees = response;  
        }
      },
      error =>{
        this.router.navigate(['error']);
      }
    );
  }

  deleteEmployee(id)
  {
    this._employeesService.deleteEmployee(id).subscribe(
      response =>{
        if(response){
          
        }
      },
      error =>{
        this.router.navigate(['error']);
      }
    );
    this.reloadCurrentPage();
  }

  insertEmployeeForm()
  {
    this.showInsert = 0;
  }

  updateEmployeeForm(id)
  {
    this.idEmployee = id;
    this.showUpdate = 0;
    this.scrollBottom();
  }

  reloadCurrentPage() {
    window.location.reload();
  }

  scrollBottom() {
    window.scroll(0,999999999999);
  }

}
