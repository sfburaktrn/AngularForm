import { Component } from '@angular/core';

@Component({
  selector: 'app-form-example',
  templateUrl: './form-example.component.html',
  styleUrls: ['./form-example.component.css'],
})
export class FormExampleComponent {
  formData = {
    name: '',
    email: '',
    age: 0,
    city: '',
    occupation: '',
  };

  onSubmit() {
    console.log('Gönderilen veriler:', this.formData);
  }
}
