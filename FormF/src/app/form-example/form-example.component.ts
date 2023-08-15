import { Component } from '@angular/core';

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

  onSubmit() {
    console.log('Gönderilen veriler:', this.formData);
  }
}
