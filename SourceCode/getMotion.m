function [x] = getMotion(x0,y0,z0,vx0,vy0,vz0,rx0,ry0,rz0,w,Tstart,Tend)

span = Tend - Tstart;

for t = 1:1:span
    x(1,t) = ((4*vx0/w)-6*z0)*sin(w*t) - (2*vz0/w)*cos(w*t) + (6*w*z0 -3*vx0)*t + (x0 + (2*vz0/w)) +((2/w^2)*rz0*(w*t - sin(w*t))) + rx0*((4/w^2*(1-cos(w*t)))-(1.5*t^2)); 
    x(2,t) = y0*cos(w*t) + (vy0/w)*sin(w*t) + ry0/w^2*(1-cos(w*t));
    x(3,t) = ((2*vx0/w)-3*z0)*cos(w*t) + (vz0/w)*sin(w*t) + (4*z0 -(2*vx0/w)) + ((2/w^2)*rx0*(sin(w*t) - w*t)) + ((rz0/w^2)*(1-cos(w*t))); 
    x(4,t) = (4*vx0-6*w*z0)*cos(w*t) + (2*vz0)*sin(w*t) + (6*w*z0 -3*vx0) +(2/w)*rz0*(1-cos(w*t)) + (4*rx0/w)*sin(w*t) -3*rx0*t;
    x(5,t) = -w*y0*sin(w*t) + vy0*cos(w*t) + (ry0/w)*sin(w*t);
    x(6,t) = ((-2*vx0)+3*w*z0)*sin(w*t) + vz0*cos(w*t)+(2*rx0/w)*(cos(w*t)-t) + (rz0/w)*sin(w*t);
end
 x =fix(x.*10^6)/10^6; % 소수점 여섯째 자리 까지만 사용하기
end

