#!/bin/bash

# Set push configuration to prevent accidental tag pushing
git config --local push.followTags false
git config --local push.default simple

# Configure git push to never push tags by default
git config --local advice.pushNonFFCurrent false
git config --local push.pushOption "no-tags"

echo "Git configuration complete in the local repository."
echo "Tags will not be pushed by default. Tags are managed by CI/CD."
echo ""
echo "If you still have issues, try: git push origin HEAD --no-tags" 