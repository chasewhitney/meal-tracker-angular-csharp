import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { GoalsComponent } from './goals/goals.component';
import { HistoryComponent } from './history/history.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent },
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'history', component: HistoryComponent},
            { path: 'goals', component: GoalsComponent },
            { path: 'dashboard', component: DashboardComponent },
        ]
    },

    { path: '**', redirectTo: '', pathMatch: 'full'}
];
