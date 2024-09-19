import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent implements OnInit {
  //to inject in the app.component
  http = inject(HttpClient);
  title = 'Basketball App';
  players: any;

  //connects to the API server
  ngOnInit(): void {
    //this HTTP object is an observable. Observables must be subscribed to
    this.http.get('https://localhost:5001/api/players').subscribe({
      //next: what to do if the observable HAS the value
      next: (response) => (this.players = response),

      //error: handles an error if the observable DOES NOT have the value
      error: (error) => console.log(error),

      //complete: what happens when the observable has no more values to return
      complete: () => console.log('Request has completed'),
    });
  }
}
