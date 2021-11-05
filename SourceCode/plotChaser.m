function [res] = plotChaser(x0,y0,z0,vx0,vy0,vz0,w,t)
    x = ((4*vx0/w)-6*z0)*sin(w*t) - (2*vz0/w)*cos(w*t) + (6*w*z0 -3*vx0)*t + (x0 + (2*vz0/w));
    y = y0*cos(w*t) + (vy0/w)*sin(w*t);
    z = ((2*vx0/w)-3*z0)*cos(w*t) + (vz0/w)*sin(w*t) + (4*z0 -(2*vx0/w));
    
    hold on;
    scatter3(x,y,z,100,'blue','filled');
    hold off;
    
    res = 1;
end