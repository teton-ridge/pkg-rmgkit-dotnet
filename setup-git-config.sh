#!/bin/bash

# Set push.followTags to false to prevent accidental tag pushing
git config push.followTags false

echo "Git configuration complete."
echo "Tags will not be pushed by default. Tags are managed by CI/CD." 