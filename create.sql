CREATE DATABASE workout_app;

CREATE TABLE users (
    user_id SERIAL PRIMARY KEY,
    username VARCHAR(255) NOT NULL UNIQUE,
    user_pass VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    phone_number VARCHAR(255) NULL UNIQUE,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE exercises (
    exercise_id SERIAL PRIMARY KEY,
    exercise_name VARCHAR(255) NOT NULL,
    category VARCHAR(255) NOT NULL,
    difficulty VARCHAR(255) NOT NULL,
    muscle_group VARCHAR(255) NOT NULL,
    exercise_description TEXT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE workouts (
    workout_id SERIAL PRIMARY KEY,
    user_id REFERENCES users(user_id),
    workout_name VARCHAR(255) NOT NULL,
    workout_date DATE NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE workout_exercises (
    workout_exercise_id SERIAL PRIMARY KEY,
    workout_id REFERENCES workouts(workout_id),
    exercise_id REFERENCES exercises(exercise_id),
    reps INT NOT NULL DEFAULT 0,
    sets INT NOT NULL DEFAULT 1,
    weight INT NOT NULL DEFAULT 0,
    duration INT NOT NULL DEFAULT 0,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

