import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

import { Employees } from '../models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }

  getEmployees(): Observable<Employees[]> 
  {
    return this.http.get<any>(environment.employees + 'Employees');
  }

  addEmployee(request: Employees) : Observable<any>
  {
    return this.http.post(environment.employees + 'Employees', request);
  }

  deleteEmployee(id : number) : Observable<any>
  {
    return this.http.delete(environment.employees + 'Employees/' + id);
  }

  updateEmployee(id : number, request : Employees) : Observable<any>
  {
    return this.http.post(environment.employees + 'Employees/' + id, request);
  }
}
