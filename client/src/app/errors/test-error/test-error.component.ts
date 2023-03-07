import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test-error',
  templateUrl: './test-error.component.html',
  styleUrls: ['./test-error.component.css']
})
export class TestErrorComponent implements OnInit {
  private urlApi: string = 'https://localhost:5001/api/';
  public validationErrors: string[] = [];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    
  }

  get400Error(): void {
    this.http.get(this.urlApi + 'bug/bad-request').subscribe({
      next: response => console.log(response),
      error: error => console.log(error)
    });
  }

  get400ValidationError(): void {
    this.http.post(this.urlApi + 'account/register', {}).subscribe({
      next: response => console.log(response),
      error: error => {
        console.log(error)
        this.validationErrors = error;
      }
    });
  }

  get401Error(): void {
    this.http.get(this.urlApi + 'bug/auth').subscribe({
      next: response => console.log(response),
      error: error => console.log(error)
    });
  }

  get404Error(): void {
    this.http.get(this.urlApi + 'bug/not-found').subscribe({
      next: response => console.log(response),
      error: error => console.log(error)
    });
  }

  get500Error(): void {
    this.http.get(this.urlApi + 'bug/server-error').subscribe({
      next: response => console.log(response),
      error: error => console.log(error)
    });
  }
}
