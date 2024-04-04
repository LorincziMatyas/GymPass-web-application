import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

interface Activity {
  name: string;
  description: string;
}

@Component({
  selector: 'app-activities',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './activities.component.html',
  styleUrl: './activities.component.scss',
})
export class ActivitiesComponent {
  activities: Activity[] = [
    {
      name: 'Enter the Gym',
      description: 'Enter the gym and start your workout routine.',
    },
    {
      name: 'Use the Shower',
      description: 'Freshen up after your workout with a refreshing shower.',
    },
    {
      name: 'Enter the Changing Room',
      description:
        'Change into your workout clothes or back into your regular attire.',
    },
    {
      name: 'Use the Sauna',
      description:
        'Relax and detoxify your body in the sauna after your workout.',
    },
    // Add more activities as needed
  ];
}
