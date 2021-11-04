function [deltav] = EquOfMotion(x0, y0, z0, vx0, vy0, vz0, w, tMax)

for t = 1:1:tMax
    x(t) = ((4*vx0/w)-6*z0)*sin(w*t) - (2*vz0/w)*cos(w*t) + (6*w*z0 -3*vx0)*t + (x0 + (2*vz0/w));
    y(t) = y0*cos(w*t) + (vy0/w)*sin(w*t);
    z(t) = ((2*vx0/w)-3*z0)*cos(w*t) + (vz0/w)*sin(w*t) + (4*z0 -(2*vx0/w));
end

scatter3(0, 0, 0, 100, 'red', 'filled')  % 타겟 디스플레이
hold on;
plot3(x, y, z, 'blue'); % 체이서 궤적 디스플레이
grid on;
title('Rendezvous Simulation')
xlabel('V - bar (m)')
ylabel('H - bar (m)')
zlabel('R - bar (m)')
hold off;
legend('Target Satellite','Chaser trajectory','Location','northwest')

deltav = 10;
end