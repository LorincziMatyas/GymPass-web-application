import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { EditAccountDialogComponent } from '../../components/edit-account-dialog/edit-account-dialog.component';

interface User {
  name: string;
  email: string;
}

interface UserPass {
  passType: string;
  expirationDate: string;
}

@Component({
  selector: 'app-account',
  standalone: true,
  imports: [],
  templateUrl: './account.component.html',
  styleUrl: './account.component.scss',
})
export class AccountComponent implements OnInit {
  ngOnInit(): void {
    console.log('Account component initialized');
  }

  constructor(private router: Router, public dialog: MatDialog) {}

  navToPasses() {
    this.router.navigate(['/passes']);
  }

  user: User = {
    name: 'John Doe',
    email: 'john.doe@example.com',
  };

  userPass: UserPass = {
    passType: 'Silver Pass',
    expirationDate: '31-12-2024',
  };

  openEditAccountDialog(): void {
    console.log('Opening edit account dialog');

    const dialogRef = this.dialog.open(EditAccountDialogComponent, {
      width: '300px',
      // margin: '100px',
      data: { user: this.user },
    });

    dialogRef.afterClosed().subscribe((result) => {
      if (result) {
        this.user = result;
      }
    });
  }

  // Fetch cart items from service and assign to a property here
}
