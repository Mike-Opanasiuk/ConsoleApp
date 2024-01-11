// Define an execution pipeline
pipeline {
    // Say that it can use any available agent (Master or Slave)
    agent any

    // Define build stages
    stages {
        stage('Checkout') {
            steps {
                // Checkout the code from the Git repository
                checkout([$class: 'GitSCM', branches: [[name: '*/main']], userRemoteConfigs: [[url: 'https://github.com/Mike-Opanasiuk/ConsoleApp.git']]])
            }
        }

        stage('Build') {
            steps {
                // Build application with restoring packages
                bat 'msbuild.exe ConsoleApp.sln /p:Configuration=Release /restore'
            }
        }

        stage('Test') {
            steps {
                // Run Unit tests
                bat 'dotnet test'
            }
        }

    }

    // Define a section that will be executed at the end of the pipeline execution
    post {
        // In case of success
        success {
            // Print that build is successful
            echo 'Build successful!'

            // We can also add additional success actions if needed
        }
        // In case of failure
        failure {
            // Print that build is failed
            echo 'Build failed!'

            // We can also add additional failure actions if needed
        }
    }
}
