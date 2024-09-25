import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { RegisterComponent } from '../register/register.component';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RegisterComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
})
export class HomeComponent implements OnInit {
  //to inject in the app.component
  http = inject(HttpClient);
  registerMode = false;
  users: any;

  ngOnInit(): void {
    this.getUsers();
  }

  registerToggle() {
    this.registerMode = !this.registerMode;
  }

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
  }

  getUsers() {
    //this HTTP object is an observable. Observables must be subscribed to
    this.http.get('https://localhost:5001/api/users').subscribe({
      //next: what to do if the observable HAS the value
      next: (response) => (this.users = response),

      //error: handles an error if the observable DOES NOT have the value
      error: (error) => console.log(error),

      //complete: what happens when the observable has no more values to return
      complete: () => console.log('Request has completed'),
    });
  }
}
