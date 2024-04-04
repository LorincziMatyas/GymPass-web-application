import { CommonModule } from '@angular/common';
import { Component, Inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-edit-account-dialog',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './edit-account-dialog.component.html',
  styleUrl: './edit-account-dialog.component.scss',
})
export class EditAccountDialogComponent {
  editedUser: any;

  constructor(
    public dialogRef: MatDialogRef<EditAccountDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.editedUser = { ...data.user };
  }

  saveChanges(): void {
    this.dialogRef.close(this.editedUser);
  }
}
