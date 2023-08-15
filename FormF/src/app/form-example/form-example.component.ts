import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-form-example',
  templateUrl: './form-example.component.html',
  styleUrls: ['./form-example.component.css'],
})
export class FormExampleComponent {
  formData = {
    name: '',
    lastname: '',
    email: '',
    age: 0,
    city: '',
  };

  constructor(private http: HttpClient) {}

  onSubmit() {
    this.http
      .post('https://localhost:5141/api/person', this.formData)
      .subscribe({
        next: (response) => {
          console.log('Gönderilen veriler:', this.formData);
          console.log('POST isteği başarılı!', response);
        },
        error: (error) => {
          console.error('Hata:', error);
        },
      });
  }
}
